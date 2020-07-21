package com.qa;

import java.util.ArrayList;
import java.util.List;

public class Customer {
	
	
	private List<Order> orders = new ArrayList();
	
	
	
	
	public Customer(List<Order> orders) {
		
		this.orders = orders;
		
	}
	
	public Order findBiggestOrder() {
		
		Order biggestOrder = orders.get(0);
		
		for(Order nextOrder : orders)
		{
			if(compareOrder(nextOrder, biggestOrder) > 0) {
				biggestOrder = nextOrder;
				
				try {
					Thread.sleep(1);
				}
				catch(InterruptedException e) {
					System.out.println(e);
				}
			}
		}
		
		return biggestOrder;
	}
	
	
	
	
      public Order findOrderByIndex(int index) {
		
		return orders.get(index);
	 }
	
	
	public int compareOrder(Order first, Order other)
	{
		if(first.getQuantity()> other.getQuantity()) {
			
			return 1;
		}
		else if(first.getQuantity()> other.getQuantity()) {
			return -1;
		}
		else
		{
			return 0;
		}
	
	}
	
	
	
	

}
