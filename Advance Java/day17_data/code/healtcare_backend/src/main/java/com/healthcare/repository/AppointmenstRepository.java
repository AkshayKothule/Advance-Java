package com.healthcare.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.healthcare.entities.Appointment;
import com.healthcare.entities.Patient;
@Repository
public interface AppointmenstRepository extends JpaRepository<Appointment, Long> {
	
	//custom query 
	
//	@Query("""
//			select new com.healthcare.dto.AppointmentDTO(a.id , a.appointmentDateTime , a.myDoctor.userDetails.firstName , a.myDoctor.userDetails.lastName) from Appointment"
//				+ " a where a.myPatient.id=:pid and a.status=:sts order by a.appointment
//			
//			""")
	

}
