package com.endmodule.GlobalException;

import org.springframework.http.HttpStatus;
import org.springframework.http.HttpStatusCode;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.ExceptionHandler;
import org.springframework.web.bind.annotation.RestControllerAdvice;

import com.endmodule.custome_exception.ResourceNotFouneException;

@RestControllerAdvice
public class GlobalException {
	@ExceptionHandler(ResourceNotFouneException.class)
	ResponseEntity<?> PolicyExceptionHander(ResourceNotFouneException e){
		return ResponseEntity.status(HttpStatus.BAD_REQUEST).body(e.getMessage());
		
	}
	@ExceptionHandler(RuntimeException.class)
	ResponseEntity<?> allExceptionHandler(RuntimeException e){
		return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body(e.getMessage());
		
	}

}
