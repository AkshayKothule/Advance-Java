package com.healthcare.service;

import java.util.List;

import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import com.healthcare.Custome_Exception.Resource;
import com.healthcare.dto.AppointmentDTO;
import com.healthcare.entities.Patient;
import com.healthcare.repository.AppointmenstRepository;
@Service
@Transactional
public class ApointmentsServiceImpl implements AppointmentsService {
	
	private final AppointmenstRepository appointmenstRepository;

	public ApointmentsServiceImpl(AppointmenstRepository appointmenstRepository) {
		super();
		this.appointmenstRepository = appointmenstRepository;
	}

	@Override
	public List<AppointmentDTO> getUpcommingAppointments(Long patientId) {
		
//		Patient patient=appointmenstRepository.findById(patientId).orElseThrow(()-> new Resource("invaild  patientId"));
		//
		
		return null;
	}

}
