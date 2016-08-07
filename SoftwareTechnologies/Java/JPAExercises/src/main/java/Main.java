import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.criteria.CriteriaBuilder;
import javax.persistence.criteria.CriteriaQuery;
import javax.persistence.criteria.Root;
import java.time.LocalDateTime;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("JPAExercises");
        EntityManager em = emf.createEntityManager();

        CriteriaBuilder cb = em.getCriteriaBuilder();

        try{
            listAllPosts(em, cb);
        } finally {
            em.close();
            emf.close();
        }
    }

    public static void listAllPosts(EntityManager entityManager, CriteriaBuilder criteriaBuilder){
        CriteriaQuery<Post> query = criteriaBuilder.createQuery(Post.class);
        Root<Post> postRoot = query.from(Post.class);

        query.select(postRoot);

        List<Post> posts = entityManager.createQuery(query).getResultList();

        for (Post post: posts) {
            System.out.printf("Title: " + post.getTitle() + "\n");
            System.out.printf("Author ID: " + post.getAuthor().getId() + "\n");
        }
    }

    public static void listAllUsers(EntityManager entityManager, CriteriaBuilder criteriaBuilder){
        CriteriaQuery<User> query = criteriaBuilder.createQuery(User.class);
        Root<User> userRoot = query.from(User.class);

        query.select(userRoot);

        List<User> users = entityManager.createQuery(query).getResultList();

        for (User user: users) {
            System.out.printf("ID: " + user.getId() + "\n");
            System.out.printf("Name: " + user.getFullname() + "\n");
            System.out.printf("Username: " + user.getUsername() + "\n");
        }
    }

    public static void orderUsersByUsername(EntityManager entityManager, CriteriaBuilder criteriaBuilder){
        CriteriaQuery<User> query = criteriaBuilder.createQuery(User.class);
        Root<User> userRoot = query.from(User.class);

        query.select(userRoot);
        query.orderBy(criteriaBuilder.asc(userRoot.get("username")));

        List<User> users = entityManager.createQuery(query).getResultList();

        for (User user: users) {
            System.out.printf("Username: " + user.getUsername() + "\n");
            System.out.printf("Name: " + user.getFullname() + "\n");

        }
    }

    public static void orderUsersBy2Params(EntityManager entityManager, CriteriaBuilder criteriaBuilder){
        CriteriaQuery<User> query = criteriaBuilder.createQuery(User.class);
        Root<User> userRoot = query.from(User.class);

        query.where(
                criteriaBuilder.gt(
                        criteriaBuilder.size(
                                userRoot.get("posts")),0))
                .select(userRoot);

        List<User> users = entityManager.createQuery(query).getResultList();

        for (User user: users) {
            System.out.printf("Username: " + user.getUsername() + "\n");
            System.out.printf("Name: " + user.getFullname() + "\n");
            System.out.printf("Count: " + user.getPosts().size() + "\n");
        }
    }

    public static void getAuthorsWithTitle(EntityManager entityManager, CriteriaBuilder criteriaBuilder){
        CriteriaQuery<Post> query = criteriaBuilder.createQuery(Post.class);
        Root<Post> postRoot = query.from(Post.class);

        query.select(postRoot);

        List<Post> posts = entityManager.createQuery(query).getResultList();

        for (Post post: posts) {
            System.out.printf("Author: " + post.getAuthor().getUsername() + "\n");
            System.out.printf("Title: " + post.getTitle() + "\n");
        }
    }

    public static void getSpecificAuthor(EntityManager entityManager, CriteriaBuilder criteriaBuilder){
        CriteriaQuery<User> query = criteriaBuilder.createQuery(User.class);
        Root<User> userRoot = query.from(User.class);

        query.where(
                criteriaBuilder.equal(userRoot.join("posts").get("id"),4))
                .select(userRoot);

        List<User> users = entityManager.createQuery(query).getResultList();

        for (User user: users) {
            System.out.printf("Username: " + user.getUsername() + "\n");
            System.out.printf("Name: " + user.getFullname() + "\n");
        }
    }

    public static void createNewPost(EntityManager entityManager, CriteriaBuilder criteriaBuilder){
        User user = entityManager.find(User.class,2);
        LocalDateTime date = LocalDateTime.now();
        Post post = new Post();

        post.setAuthor(user);
        post.setTitle("Random Title");
        post.setContent("Random Content");
        post.setDate(date);

        entityManager.getTransaction().begin();
        entityManager.persist(post);
        entityManager.getTransaction().commit();
    }

    public static void editPost(EntityManager entityManager, CriteriaBuilder criteriaBuilder){
        Post post = entityManager.find(Post.class, 34);

        post.setContent("Random Content should be replaced");

        entityManager.getTransaction().begin();
        entityManager.persist(post);
        entityManager.getTransaction().commit();
    }

    public static void deletePost(EntityManager entityManager){
        Post post = entityManager.find(Post.class, 34);

        entityManager.getTransaction().begin();

        post.getComments().clear();
        post.getTags().clear();
        entityManager.remove(post);

        entityManager.getTransaction().commit();
    }
}
