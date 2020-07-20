package com.qa;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.fail;

import java.util.ArrayList;
import java.util.List;

import org.junit.Before;
import org.junit.Test;

public class CustomerTest {
	
	private Customer customer;
	
	private List<Order> orders;
	
	
	
	@Before
	public void setUp() {
		
		orders = new ArrayList<Order>();

		for(int i = 1; i<=3000; i++)
			orders.add(new Order(i,"Order "+i));
		
		customer = new Customer(orders); // Initialises Fixture with some orders
	}

	@Test
	public void testFindBiggestOrder() {
		
	  Order biggestOrder = customer.findBiggestOrder();
	  
	  int expectedQty = 3000;
	  
	  assertEquals("", expectedQty,biggestOrder.getQuantity());
	}

	@Test
	public void testFindOrderByIndex0() {
		
		Order order = customer.findOrderByIndex(0);
		  
		int qty = 1;
		
		assertEquals("", qty,order.getQuantity());
	}

}
