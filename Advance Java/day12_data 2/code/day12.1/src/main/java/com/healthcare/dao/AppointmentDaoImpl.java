package com.healthcare.dao;

import static com.healthcare.utils.HibernateUtils.getFactory;

import java.time.LocalDateTime;
import java.util.List;

import org.hibernate.Session;
import org.hibernate.Transaction;

import com.healthcare.dto.AppointmentDTO;
import com.healthcare.entities.Appointment;
import com.healthcare.entities.Doctor;
import com.healthcare.entities.Patient;
import com.healthcare.entities.Status;

public class AppointmentDaoImpl implements AppointmentDao {

	@Override
	public String bookAppointment(Long doctorId, Long patientId, LocalDateTime ts) {
		String mesg = "Appointment un available , Please choose another Date/Time";
		
//		String Jpql=""
		// 1. Get Session from SessionFactory
		Session session = getFactory().getCurrentSession();
		// 2. Begin Tx
		Transaction tx = session.beginTransaction();
		try {
			
			if(isDoctorAvailable(doctorId, ts)) {
				
				Doctor doctor=session.find(Doctor.class, patientId);
				Patient patient=session.find(Patient.class, patientId);
				
//				session.persist(Appointment);
				
			}


			
			
			tx.commit();
		} catch (RuntimeException e) {
			if (tx != null)
				tx.rollback();
			// re throw the exception to the caller
			throw e;
		}
		return mesg;
	}

	@Override
	public String cancelAppointment(Long appointmentId, Long patientId) {
		// 1. Get Session from SessionFactory
		Session session = getFactory().getCurrentSession();
		// 2. Begin Tx
		Transaction tx = session.beginTransaction();
		try {

			tx.commit();
		} catch (RuntimeException e) {
			if (tx != null)
				tx.rollback();
			// re throw the exception to the caller
			throw e;
		}
		return null;
	}

	private boolean isDoctorAvailable(Long docId, LocalDateTime ts) {
		
		//jpql 
		String jpql="select a from Appointment a where a.myDoctor.doctor_id =:doctid and a.appointmentDateTime != :ts1";
		// 1. Get Session from SessionFactory
		
		Session session = getFactory().getCurrentSession();
		// 2. Begin Tx
		Transaction tx = session.beginTransaction();
		try {
			Appointment appointment=session.createQuery(jpql, Appointment.class)
			.setParameter("doctid", docId)
			.setParameter("ts1",ts )
			.uniqueResult();
			
			//doctor is avavlobale 
			if(appointment == null) {
				return true;
			}
			
			tx.commit();
		} catch (RuntimeException e) {
			if (tx != null)
				tx.rollback();
			// re throw the exception to the caller
			throw e;
		}
		return false;
	}

	@Override
	public List<AppointmentDTO> listUpcomingAppointmentsForPatient(Long patientId) {
		// 1. Get Session from SessionFactory
		List<AppointmentDTO> upAppointments=null;
		String jpql="select new com.healthcare.dto.AppointmentDTO(a.id , a.appointmentDateTime , a.myDoctor.userDetails.firstName , a.myDoctor.userDetails.lastName) from Appointment"
				+ " a where a.myPatient.id=:pid and a.status=:sts";
		Session session = getFactory().getCurrentSession();
		// 2. Begin Tx
		Transaction tx = session.beginTransaction();
		try {
			
			upAppointments=session.createQuery(jpql, AppointmentDTO.class)
			.setParameter("pid",patientId)
			.setParameter("sts", Status.SCHEDULED)
			.getResultList();
			tx.commit();
		} catch (RuntimeException e) {
			if (tx != null)
				tx.rollback();
			// re throw the exception to the caller
			throw e;
		}
		return upAppointments;
	}

	@Override
	public List<AppointmentDTO> listUpcomingAppointmentsForDoctor(Long doctorId) {

		// 1. Get Session from SessionFactory
		Session session = getFactory().getCurrentSession();
		// 2. Begin Tx
		Transaction tx = session.beginTransaction();
		try {
			tx.commit();
		} catch (RuntimeException e) {
			if (tx != null)
				tx.rollback();
			// re throw the exception to the caller
			throw e;
		}
		return null;

	}

}
