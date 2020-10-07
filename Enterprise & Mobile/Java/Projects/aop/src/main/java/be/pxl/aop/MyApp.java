package be.pxl.aop;

import org.springframework.context.ConfigurableApplicationContext;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;

public class MyApp {
    public static void main(String[] args) {

        try(ConfigurableApplicationContext ctx =
                    new AnnotationConfigApplicationContext(AppConfig.class)) {
            MyInterface bean = ctx.getBean("myBean", MyInterface.class);
            bean.sayHello("Tom");
        }
    }
}
