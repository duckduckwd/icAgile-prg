package com.qa;

import static org.junit.Assert.*;

import org.junit.Test;

public class IsAPostCodeTest {
	
	
	
	@Test
	public void testIsAPostCode() {
		
		assertThat("WC1", IsAPostCode.isAPostCode());
		
		
	}
	

	@Test
	public void testIsAPostCode2() {
		
		assertThat("WC123", IsAPostCode.isAPostCode());
		
		
	}

}
