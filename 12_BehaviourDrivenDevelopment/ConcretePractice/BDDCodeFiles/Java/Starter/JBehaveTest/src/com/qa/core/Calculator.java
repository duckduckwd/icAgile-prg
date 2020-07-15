package com.qa.core;

public class Calculator {
	private int sum;

	public Calculator() {
		this.sum = 0;
	}

	public void addTwoNumber(int x, int y) {
		sum = x + y;
	}

	public int getresult() {
		return this.sum;
	}
}