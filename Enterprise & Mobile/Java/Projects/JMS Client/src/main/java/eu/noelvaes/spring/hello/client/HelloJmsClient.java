package eu.noelvaes.spring.hello.client;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.ConfigurableApplicationContext;

@SpringBootApplication
public class HelloJmsClient {
   public static void main(String[] args) throws Exception {
      ConfigurableApplicationContext ctx = SpringApplication.run(
         HelloJmsClient.class, args);
      HelloSender sender = ctx.getBean(HelloSender.class);
      sender.sendHello("World");
   }
}
