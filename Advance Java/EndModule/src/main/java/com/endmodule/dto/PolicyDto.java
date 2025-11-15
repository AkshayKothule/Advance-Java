package com.endmodule.dto;

import java.time.LocalDate;

import com.endmodule.entites.PolicyType;

import jakarta.validation.constraints.NotBlank;
import jakarta.validation.constraints.NotNull;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
//lombok
@Setter
@Getter
@NoArgsConstructor
@AllArgsConstructor
public class PolicyDto {
	
	@NotBlank
	private String policyName;
	@NotNull
	private Double coverageAmount;
	@NotNull
	private Double premiumAmount;
	
	private LocalDate startdate;
	
	private LocalDate endDate;
	@NotNull
	private PolicyType policy;
	

}
