package eu.noelvaes.spring.hello.services;

import javax.jms.*;
import org.springframework.jms.annotation.JmsListener;
import org.springframework.stereotype.Service;

@Service
public class HelloJmsReceiver {

   @JmsListener(destination="HelloQueue")
   public void onMessage(Message msg) {      
      try {
         if(msg instanceof TextMessage) {
            String text = ((TextMessage)msg).getText();
            System.out.println("Hello " + text);
         }
      }
      catch (JMSException e) {
         e.printStackTrace();
      }
   }
}
