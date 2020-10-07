package be.pxl.aop;

import org.springframework.stereotype.Component;

@Component
public class MyBean implements MyInterface {
    public void sayHello(String name) {
        System.out.println("Hello " + name);
    }
}
