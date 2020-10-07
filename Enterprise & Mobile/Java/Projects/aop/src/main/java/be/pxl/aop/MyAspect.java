package be.pxl.aop;

import org.aspectj.lang.annotation.Aspect;
import org.aspectj.lang.annotation.Before;
import org.springframework.stereotype.Component;

@Component
@Aspect
public class MyAspect {

    @Before("execution(* * .sayHello(..))")
    public void before(){
        System.out.println("Before");
    }
}
