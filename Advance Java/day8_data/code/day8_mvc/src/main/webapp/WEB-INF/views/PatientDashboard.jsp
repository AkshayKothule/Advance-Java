<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
  <!--   import jstl core tag liberey -->
    <%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>patient dashboard</title>
</head>
<body>

<!-- for(int i : arr) -->
<h5>hello :${sessionScope.patient_details.name}</h>

<c:forEach var="appointment" items="${requestScope.appointment_list}">
${appointment.appointmentId}</br>
${appointment.appointmentTS}</br>
${appointment.docName}</br>

<%-- <tr>
<td>${appointment.appointmentId}</td>
<td>${appointment.appointmentTS}</td>
<td>${appointment.docName} </td>
<td>Cancle Button</td> --%>

</tr>
   <br/>
</c:forEach>
<h5>
<a href="appointments?action='show_form"> Book new Appointment</a>
</h5>
<h5>
<a href="logout.jsp">LogOut</a>
</h5>

</body>
</html>