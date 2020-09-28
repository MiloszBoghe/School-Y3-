package eu.noelvaes.spring.hello.web;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/hello")
public class HelloRestController {
   @RequestMapping(method = RequestMethod.GET, produces = "text/plain")
   public String handleGetPlain() {
      System.out.println("GET PLAIN");
      return "Hello World";
   }

   @RequestMapping(method = RequestMethod.GET, produces = "text/html")
   public String handleGetHtml() {
      System.out.println("GET HTML");
      return "<html><body>Hello World</body></html>";
   }

   @RequestMapping(method = RequestMethod.POST)
   public String handlePost() {
      System.out.println("POST");
      return "Hello World";
   }

   @RequestMapping(method = RequestMethod.PUT)
   public String handlePut() {
      System.out.println("PUT");
      return "Hello World";
   }

   @RequestMapping(method = RequestMethod.DELETE)
   public String handleDelete() {
      System.out.println("DELETE");
      return "Hello World";
   }

   @RequestMapping(method = RequestMethod.PATCH)
   public String handlePatch() {
      System.out.println("PATCH");
      return "Hello World";
   }
}
