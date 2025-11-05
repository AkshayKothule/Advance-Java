package com.healthcare.Custome_Exception;

public class Resource extends RuntimeException{
	public Resource(String errMsg) {
		super(errMsg);
	}

}
