<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Book Appointment </title>
</head>
<body>
<!-- get patient name -->
<h5>hello : ${sessionScope.patient_details.name}</h5>
<form action="appointments" method="post">
      <input type="hidden" name="action" value="book">
      <table style="background-color: lightgrey; margin: auto">
        <tr>
          <td>Doctor ID</td>
          <td><input type="number" name="doc_id" required/></td>
        </tr>
       
	 <tr>
          <td>Appointment Date Time</td>
	  <td><input type="datetime-local" name="appointment_ts" required></td>
         </tr>
        <tr>
          <td><input type="submit" value="Book Appointment" /></td>
        </tr>
      </table>
    </form>
</body>
</html>