
Test{
	
	Hele testklasse voorbeeld{
		[TestFixture]
		public class AccountManagerTests
		{
			private AccountManager accountManager;
			private Account fromYouthAccount;
			private Account fromOtherAccount;
			private Account toAccount;

			[SetUp]
			public void SetUp()
			{
				accountManager = new AccountManager();

				toAccount = new Account()
				{
					Balance = 500
				};
			}

			[Test]
			public void ShouldCorrectlyTransferMoneyWhenBalanceIsSufficient()
			{
				CreateOtherAccount();
				accountManager.TransferMoney(fromOtherAccount, toAccount, 1000);
				Assert.That(fromOtherAccount.Balance, Is.EqualTo(1000));
				Assert.That(toAccount.Balance, Is.EqualTo(1500));
			}

			[Test]
			public void ShouldThrowInvalidTransferExceptionWhenBalanceIsInsufficient()
			{
				CreateOtherAccount();
				Assert.Throws<InvalidTransferException>(() => accountManager.TransferMoney(fromOtherAccount, toAccount, 5000));
			}

			[Test]
			public void ShouldThrowInvalidTransferExceptionForYouthAccountWhenAmountIsBiggerThan1000()
			{
				CreateYouthAccount();
				Assert.Throws<InvalidTransferException>(() => accountManager.TransferMoney(fromYouthAccount, toAccount, 2000));
			}

			public void CreateYouthAccount()
			{
				fromYouthAccount = new Account()
				{
					Balance = 3000,
					AccountType = AccountType.YouthAccount
				};
			}

			public void CreateOtherAccount()
			{
				fromOtherAccount = new Account()
				{
					Balance = 2000
				};
			}
		}
	}
	
	
	
	Assert Equal{
		//Assert.That(METHODE, Is.EqualTo(UITKOMST));
		Assert.That(fromOtherAccount.Balance, Is.EqualTo(1000));
	}
	
	Exception{
		//Om te kijken of een methode een specifieke exception throwed:
		//Assert.Throws<EXCEPTIONTYPE>(() => METHODE);
		Assert.Throws<InvalidTransferException>(() => accountManager.TransferMoney(fromYouthAccount, toAccount, 2000));
	}
	
}

Databases{

	string connectionString =
		"Data Source={localdb}" +
		"\\MSSqllocalDb;" +
		"Initial Catalog=Payables;" +
		"Integrated Security=True";
	return new SqlConnection(connectionString);
	
	// OF (Kies 1)
	
	SqlConnectionStringBuilder connBuilder = new SqlConnectionStringBuilder()
	{
		DataSource = "(localdb)\\MSSqllocalDb",
		InitialCatalog = "Payables",
		IntegratedSecurity = true
	};
	return new SqlConnection(connBuilder.ConnectionString);

}
	
EntityFramework{
	//nieuwe solution? Voeg projecten toe: (
	//[Naam].Data (CLASS LIBRARY - NET FRAMEWORK)
	//[Naam].Domain (CLASS LIBRARY - NET FRAMEWORK)
	//UI (WPF - NET FRAMEWORK)
	//rightclick .Data-->manage nuGet --> microsoft.entityframeworkcore --> .Sqlserver (VERSIE 2.2.6!!) --> install

	Context{
		//In de .Data zal moet de context klasse staan. Deze extend "DbContext"
		//wat doen?
		//1. alle DbSets aanmaken als properties (tip: prop tab tab)
		//2. override OnConfiguring
		public class SamuraiContext:DbContext
		{
			public DbSet<Samurai> Samurais { get; set; }
			public DbSet <Battle> Battles { get; set; }
			public DbSet<Quote> Quotes { get; set; }
		
			protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			{
				string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SamuraiAppData;Integrated Security=True";
				optionsBuilder.UseSqlServer(connectionString);
				
			}
		}
	}
	
	
	Migrations{
		//Volg deze stappen:
		//Om migrations te kunnen doen --> .Data --> Manage nuGet --> microsoft.entityframeworkcore.tools (VERSIE 2.2.6)!!-->install
		//UI --> add reference-->projects--> .Data en .Domain
		//UI --> rightclick --> manage nuGet --> microsoft.entityframeworkcore.design --> install
		//UI --> rightclick --> set as startup project
		//Tip: Voor packet manager console: View-->other windows --> packet manager console
		//Tip: in de packet manager console: get-help entityframeworkcore
		//in de console --> Default project: .Data
	
		Add-Migration{
			//in console
			add-migration initial
		}
		
		Script-Migration{
			//in console:
			script-migration
			//Dit maakt een .sql file met de hele sql in.
			//Waarschijnlijk niet nodig. Dit is om te delen met andere mensen in een project ofzo.
		}
		
		Update-Database{
			//in console:
			update-database
			//als de database nog niet bestaat zal het deze ook aanmaken. 
		}
		
	}


	Relationships{
		//one to one, many to many, ...

		One to one{
			//nieuwe klasse om in dit geval de echte naam van een samurai bij te houden.
			//deze heeft een PK "Id" en samuraiId en samuraiNaam.
			public class SecretIdentity
			{
				public int Id { get; set; }
				public string RealName { get; set; }
				public int SamuraiId { get; set; }
			}
			
			//Aan de Samurai klasse voegen we ook een property toe:
			public SecretIdentity SecretIdentity{get; set; }
			//nu kan EFCore er aan uit. In orde.
			
		}
			
		
		One to many{
			//Extra property maken in de domain klassen
			//In de klasse die "one" van iets heeft --> [Object] Object:
			public class Post
			{
				public int PostId { get; set; }
				public string Title { get; set; }
				public string Content { get; set; }

				public int BlogId { get; set; }
				public Blog Blog { get; set; }
			}
			//In de klasse met many van iets --> ICollection<[WatHijVeelHeeft]>:
			public class Blog
			{
				public int BlogId { get; set; }
				public string Url { get; set; }

				public ICollection<Post> Posts { get; set; }
			}


			//Dan kunnen we in de OnModelCreating klasse:
			//deze staat in de context klasse:
			public class BankContext : DbContext
			{
				protected override void OnModelCreating(ModelBuilder modelBuilder)
				{
					modelBuilder.Entity<Post>()
						.HasOne(a => a.Blog)
						.WithMany(b => b.Posts)
						.HasForeignKey(c => c.BlogId)
						.HasPrincipalKey(d => d.Url);
				}
			}
		}
		
		
		Many to many{
			//Voor een many to many relationship (bv Samurais meerdere battles, battles meerdere samurais)
			//Moet er een join entity aangemaakt worden. Dit is een nieuwe klasse in .Domain
			//Deze heeft de primary keys van beide (Id)
			//
			public class SamuraiBattle
			{
				public int SamuraiId { get; set; }
				public Samurai Samurai { get; set; }
				public int BattleId { get; set; }
				public Battle Battle { get; set; }
			}
			
			//Dan pas je in Battle klasse en Samurai klasse de properties aan:
			//In Samurai:
			public class Samurai
			{
				//public int BattleId { get; set; } DEZE GAAT IN COMMENT
				//in de plaats komt deze:
				public List<SamuraiBattle> SamuraiBatttles {get; set; }
			}
			//in Battle:
			public class Battle
			{
				//public List<Samurai> Samurais { get; set; } DEZE GAAT IN COMMENT
				//in de plaats komt deze:
				public List<SamuraiBattle> SamuraiBatttles { get; set; }
			}
			
			//Dan naar de Context klasse:
			protected override void OnModelCreating(ModelBuilder modelBuilder)
			{
				modelBuilder.Entity<SamuraiBattle>().HasKey(s => new { s.SamuraiId, s.BattleId }); 
			}
		}

	
}
		
		
	
	modelBuilder (Required, PK, ...){
		//Om een property required te maken:
		modelBuilder.Entity<Person>().Property(p => p.Name).IsRequired();

		
		//Om aan EFCore duidelijk te maken wat de PK is --> in de context klasse:
		protected override void OnModelCreating(ModelBuilder modelBuilder){
			modelBuilder.Entity<Blog>().HasKey(b => b.Url);
		}
	}


	Add{
		public void Add(Customer newCustomer)
		{
			if (_bankContext.Customers.Contains(newCustomer)) throw new ArgumentException();
			_bankContext.Entry(newCustomer).State = EntityState.Added;
			_bankContext.SaveChanges();
		}
	}


	Update{
		//KIES 1:
		public void Update(Customer existingCustomer)
		{
			if (!_bankContext.Customers.Contains(existingCustomer)) throw new ArgumentException();
			_bankContext.Update(existingCustomer);
			_bankContext.SaveChanges();
		}
	
	
		public void UpdateCustomer(int customerId, Customer source)
		{
			Customer customer = _context.Customers.Find(customerId);
			if (customer == null)  throw new ArgumentException() ;
			_context.Entry(customer).CurrentValues.SetValues(source);
		}

	}
	

	GetAll{
		public IList<City> GetAll()
        {
           return _bankContext.Cities.ToList();
        }
		
		//Het kan zijn dat je bijvoorbeeld een lijst van accounts ook moet hebben, waar geen kolom voor bestaat
		//in je database. Maar wel een collectie in je domain klasse. Om deze mee te nemen moet je een include doen:
        public ICollection<Customer> GetAll()
        {
            // DONE: voeg de code toe om alle klanten op te halen
            return _context.Customers.Include(c => c.Accounts).ToList();
        }
	}
	

}

Linq{
	
	Join{
		//voegt een list samen met komma's tussen elk element
		string.Join(",", list)
	}
	
	OrderBy{
		//sorteert een list op wat je wil..
		list.OrderBy(a => a.[PropertyNaam]) //sorteert op die property.	
	}
	
	Select{
		//selecteert alleen een bepaalde property uit elk element van de list
		list.Select(n=>n.Number) //Pakt alleen het "Number"
	}
	
	Include{
		//Get maar met de one to many erbij ofzo:
		public IList<Customer> GetAllWithAccounts()
		{
			return _bankContext.Customers.Include(c=>c.Accounts).ToList();
		}
	}
}



