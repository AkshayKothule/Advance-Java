package com.healthcare.dto;

import java.time.LocalDateTime;

import lombok.Getter;
import lombok.Setter;

//@Getter
//@Setter
public class ApiResponse {
	public LocalDateTime getTimeStamp() {
		return timeStamp;
	}
	public void setTimeStamp(LocalDateTime timeStamp) {
		this.timeStamp = timeStamp;
	}
	public String getMessage() {
		return message;
	}
	public void setMessage(String message) {
		this.message = message;
	}
	public String getStatus() {
		return status;
	}
	public void setStatus(String status) {
		this.status = status;
	}
	private LocalDateTime timeStamp;
	private String message;
	private String status;// success | failed
	public ApiResponse(String message, String status) {
		super();
		this.message = message;
		this.status = status;
		this.timeStamp=LocalDateTime.now();
	}
	
}
