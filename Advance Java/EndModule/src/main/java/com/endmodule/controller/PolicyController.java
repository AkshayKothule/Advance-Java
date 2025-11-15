package com.endmodule.controller;

import org.springframework.http.HttpStatus;
import org.springframework.http.HttpStatusCode;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.endmodule.dto.PolicyDto;

import lombok.AllArgsConstructor;
import com.endmodule.service.*;

import jakarta.validation.Valid;

@RestController
@RequestMapping("/policy")
@AllArgsConstructor
public class PolicyController {
	
	private final PolicyService policyService;
	
	@PostMapping("/add")
	ResponseEntity<?> addNewPolicy(@RequestBody  @Valid PolicyDto policyDto){
		return ResponseEntity.ok(policyService.addnewPolicy(policyDto));
		
	}
	
	/*
	 * Delete a policy by policy number
	 * */
	@DeleteMapping("/{policyNo}")
	ResponseEntity<?> deletePolicy(@PathVariable Long policyNo){
		return ResponseEntity.status(HttpStatus.OK).body(policyService.deleteByPlolicyNo(policyNo));
	}
//	
//	/*
//	 * Find all policies
//	 * */
    @GetMapping("/AllPolicy")
    ResponseEntity<?> addNewPolicy(){
		return ResponseEntity.ok(policyService.getAllPolicies());
		
	}
//    
//    /*
//     * Find policies by policy type
//     *
//     * */
    @GetMapping("/{PolicyType}")
    ResponseEntity<?> getAllPolicyType(@PathVariable String PolicyType ){
    	return ResponseEntity.ok(policyService.getByPolicyCategory(PolicyType));
    }
//    
//    /*
//     * Search by policy name
//     * */
//   
    @GetMapping("/policyName/{policeName}")
    ResponseEntity<?> getAllPolicyByPolicyName(@PathVariable String policeName ){
    	return ResponseEntity.ok(policyService.getByPolicyName(policeName));
    }
/* Update coverage amount

Find all policies where the coverageAmount > 7,00,000,
and increase their coverage amount by 15%.  */
    @PostMapping("/CoverageAmount")
	ResponseEntity<?> UpdateByCoverageAmount(){
		return ResponseEntity.ok(policyService.updateCoverageAmount());
		
	}
    
}
