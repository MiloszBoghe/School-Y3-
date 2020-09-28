package eu.noelvaes.spring.hello;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.Bean;
import org.springframework.jms.annotation.EnableJms;
import org.springframework.security.config.annotation.authentication.builders.AuthenticationManagerBuilder;
import org.springframework.security.config.annotation.web.WebSecurityConfigurer;
import org.springframework.security.config.annotation.web.builders.*;
import org.springframework.security.config.annotation.web.configuration.WebSecurityConfigurerAdapter;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;

@SpringBootApplication
// @SpringBootApplication(exclude=org.springframework.boot.autoconfigure.security.servlet.SecurityAutoConfiguration.class)
@EnableJms
public class HelloApp {
   public static void main(String[] args) {
      SpringApplication.run(HelloApp.class, args);
   }

   @Bean
   public WebSecurityConfigurer<WebSecurity> securityConfigurer() {
      return new WebSecurityConfigurerAdapter() {
         @Override
         protected void configure(AuthenticationManagerBuilder auth) throws Exception {
            auth.inMemoryAuthentication()
                .passwordEncoder(new BCryptPasswordEncoder())
                .withUser("homer")
                .password("$2a$10$6ijNwwL19abb5t/kD2AqLeMYi8/fNuldNSSrU9h6CLHEhAWW6IB.S")
                .roles("ADULT")
                .and()
                .withUser("bart")
                .password("$2a$10$6ijNwwL19abb5t/kD2AqLeMYi8/fNuldNSSrU9h6CLHEhAWW6IB.S")
                .roles("MINOR");
         }

         @Override
         protected void configure(HttpSecurity http)
               throws Exception {
            http.httpBasic();
            http.authorizeRequests()
                .antMatchers("/hello/**")
                .hasRole("ADULT");
         }
      };
   }
}
