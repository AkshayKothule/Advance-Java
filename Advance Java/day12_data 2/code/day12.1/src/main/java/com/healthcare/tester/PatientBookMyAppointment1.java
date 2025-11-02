package com.healthcare.tester;

import static com.healthcare.utils.HibernateUtils.getFactory;

import java.time.LocalDateTime;
import java.time.LocalTime;
import java.util.Scanner;

import org.hibernate.SessionFactory;

import com.healthcare.dao.AppointmentDao;
import com.healthcare.dao.AppointmentDaoImpl;
import com.healthcare.dao.PatientDao;
import com.healthcare.dao.PatientDaoImpl;
import com.healthcare.dao.UserDao;
import com.healthcare.dao.UserDaoImpl;
import com.healthcare.entities.Patient;
import com.healthcare.entities.User;
import com.healthcare.entities.UserRole;

public class PatientBookMyAppointment1 {

	public static void main(String[] args) {
		try (Scanner sc = new Scanner(System.in); SessionFactory sf = getFactory()) {
			
          //
			AppointmentDao appointmentdao=new AppointmentDaoImpl();
			
			System.out.println("Enter a doctor id , patient id , appointment TS");
			System.out.println(appointmentdao.bookAppointment(sc.nextLong(), sc.nextLong(),LocalDateTime.parse(sc.next())));
			
			
		} catch (Exception e) {
			e.printStackTrace();
		}

	}

}
