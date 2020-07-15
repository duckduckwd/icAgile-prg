package com.qa;

public class Order {
	
	
	private int quantity;
	
	private String orderDesc;

	public Order(int quantity, String orderDesc) {
		super();
		this.quantity = quantity;
		this.orderDesc = orderDesc;
	}

	@Override
	public String toString() {
		return "Order [quantity=" + quantity + ", orderDesc=" + orderDesc + "]";
	}

	public int getQuantity() {
		return quantity;
	}

	public void setQuantity(int quantity) {
		this.quantity = quantity;
	}

	public String getOrderDesc() {
		return orderDesc;
	}

	public void setOrderDesc(String orderDesc) {
		this.orderDesc = orderDesc;
	}
	
	

}
