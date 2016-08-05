/**
 * Created by Ina PC on 8/5/2016.
 */
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.criteria.CriteriaBuilder;
import javax.persistence.criteria.CriteriaQuery;
import javax.persistence.criteria.Root;

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
            System.out.printf("Title " + post.getTitle());
            System.out.printf("Author ID " + post.getAuthor().getId());
        }
    }
}
