package com.healthcare.dto;
/*Data Transfer object - meant to transfer the data between the layers DAO-> Servlet
 * Later - it will be used to transfer the data REST client & REST server
 * Then it will be used to transfer the data between different MS
 */

import java.time.LocalDateTime;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import lombok.ToString;
//@NoArgsConstructor
//@AllArgsConstructor
//@Getter
//@Setter
//@ToString
public class AppointmentDTO {
	
	@Override
	public String toString() {
		return "AppointmentDTO [appointmentId=" + appointmentId + ", appointmentTS=" + appointmentTS + ", firstName="
				+ firstName + ", lastName=" + lastName + "]";
	}
	public AppointmentDTO() {
		super();
	}
	public AppointmentDTO(Long appointmentId, LocalDateTime appointmentTS, String firstName, String lastName) {
		super();
		this.appointmentId = appointmentId;
		this.appointmentTS = appointmentTS;
		this.firstName = firstName;
		this.lastName = lastName;
	}
	public Long getAppointmentId() {
		return appointmentId;
	}
	public void setAppointmentId(Long appointmentId) {
		this.appointmentId = appointmentId;
	}
	public LocalDateTime getAppointmentTS() {
		return appointmentTS;
	}
	public void setAppointmentTS(LocalDateTime appointmentTS) {
		this.appointmentTS = appointmentTS;
	}
	public String getFirstName() {
		return firstName;
	}
	public void setFirstName(String firstName) {
		this.firstName = firstName;
	}
	public String getLastName() {
		return lastName;
	}
	public void setLastName(String lastName) {
		this.lastName = lastName;
	}
	private Long appointmentId;
	private LocalDateTime appointmentTS;
	private String firstName;
	private String lastName;
}
