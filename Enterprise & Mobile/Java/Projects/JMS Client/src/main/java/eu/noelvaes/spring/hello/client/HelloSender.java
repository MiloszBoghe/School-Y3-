package eu.noelvaes.spring.hello.client;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jms.core.JmsTemplate;
import org.springframework.stereotype.Component;

@Component
public class HelloSender {
   @Autowired
   private JmsTemplate jmsTemplate;
   
   public void sendHello(String text) {      
      //jmsTemplate.setPubSubDomain(true);
      //jmsTemplate.send("HelloQueue",s -> s.createTextMessage(text));   
      jmsTemplate.convertAndSend("HelloQueue",text);
      
   }
}
