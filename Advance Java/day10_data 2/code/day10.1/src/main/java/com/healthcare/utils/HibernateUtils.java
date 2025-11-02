package com.healthcare.utils;
import org.hibernate.*;
import org.hibernate.cfg.Configuration;

public class HibernateUtils {
	
	
	private static SessionFactory factory;
	static {  //
		System.out.println("in static block");
		
		//create a singleton instance of session fractory
		factory=new Configuration() //empty sesssion factory  
				.configure() //hibernate loads the props & mappings from cfg file in config class
				.buildSessionFactory(); // get session factory 
	}
	//getter 
	public static SessionFactory getFactory() {
		return factory;
	}
	

}
