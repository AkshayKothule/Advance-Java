package com.endmodule.entites;

import java.time.LocalDate;

import jakarta.persistence.Entity;
import jakarta.persistence.EnumType;
import jakarta.persistence.Enumerated;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Entity
//lombok
@Setter
@Getter
@NoArgsConstructor
@AllArgsConstructor
public class Policy {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Long policyNumber;
	
	private String policyName;
	private Double coverageAmount;
	private Double premiumAmount;
	private LocalDate startdate;
	private LocalDate endDate;
	@Enumerated(EnumType.STRING)
	private PolicyType policy;
	

}
