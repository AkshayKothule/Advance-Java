package com.healthcare.service;

import java.util.List;

import com.healthcare.dto.AppointmentDTO;

public interface AppointmentsService {

	List<AppointmentDTO>getUpcommingAppointments(Long patientId);

}
