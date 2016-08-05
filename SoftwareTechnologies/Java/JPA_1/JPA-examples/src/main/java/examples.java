import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import java.util.Date;

public class examples {
    public static void main(String[] args) {
        EntityManagerFactory emf = Persistence
                .createEntityManagerFactory("blog-db");
        EntityManager em = emf.createEntityManager();
        try {
            em.getTransaction().begin();
            for (int i = 0; i < 10; i++) {
                User newUser = new User();
                newUser.setUsername("pesho" + new Date().getTime());
                newUser.setFullName("Petyr Ivanov" + i);
                newUser.setPasswordHash("345678965432");
                em.persist(newUser);
                for (int j = 0; j < 5; j++) {
                    Post post = new Post();
                    post.setAuthor(newUser);
                    post.setTitle("Title" + j + i*10);
                    post.setBody("<p>Hello</p>");
                    em.persist(post);
                }
                System.out.println("Created new user #" + newUser.getId());
            }
            em.getTransaction().commit();
        }
        finally {
            em.close();
            emf.close();
        }
    }
}
