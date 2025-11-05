package com.healthcare.controller;

import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.healthcare.service.AppointmentsService;

/*
 * 
 * URL :http://host:port/patients/{patientId}/appointments/upcomaing
 * Method :- GET
 * payLoad : 
 * */
@RestController
@RequestMapping("/patients")

public class PatientController {
	
	public PatientController(AppointmentsService appointmentsService) {
		super();
		this.appointmentsService = appointmentsService;
	}
	private final AppointmentsService appointmentsService;
	@GetMapping("/{patientId}/appointments")
	public ResponseEntity<?> getAllUpcomingAppointments(@PathVariable Long patientId){
		
		try {
			
			return ResponseEntity.ok(appointmentsService.getUpcommingAppointments(patientId));
			
		}catch(RuntimeException e) {
			
			
			
		}
		return null;
		
		
		
	}

}
