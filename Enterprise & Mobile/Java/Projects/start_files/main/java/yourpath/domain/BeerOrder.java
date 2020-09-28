package eu.noelvaes.spring.beers.domain;

import java.util.*;

import javax.persistence.*;

@Entity
@Table(name = "BeerOrders")
public class BeerOrder {
   @Id
   @GeneratedValue(strategy = GenerationType.IDENTITY)
   @Column(name = "Id")
   private int id;

   @Column(name = "Name")
   private String name;

   @OneToMany(cascade = { CascadeType.ALL },fetch=FetchType.EAGER)
   @JoinColumn(name = "BeerOrderId")
   private List<BeerOrderItem> items = new ArrayList<>();

   public String getName() {
      return name;
   }

   public void setName(String name) {
      this.name = name;
   }

   public List<BeerOrderItem> getItems() {
      return items;
   }

   public void setItems(List<BeerOrderItem> items) {
      this.items = items;
   }

   public int getId() {
      return id;
   }
}
