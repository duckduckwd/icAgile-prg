package com.qa;

import org.hamcrest.Description;
import org.hamcrest.Factory;
import org.hamcrest.Matcher;
import org.hamcrest.TypeSafeMatcher;

public class IsAPostCode extends TypeSafeMatcher<String> {

	@Override public boolean matchesSafely(String code) {
		String regex = "[A-Z]{1,2}[0-9]{1,2}\\s*([0-9][A-Z]{2})?";
		return code.matches(regex);
	}

	@Override public void describeTo(Description description) {
		description.appendText("a valid UK postcode");
	}

	@Factory
	public static <T> Matcher<String> isAPostCode() {
		return new IsAPostCode();
	}
}
