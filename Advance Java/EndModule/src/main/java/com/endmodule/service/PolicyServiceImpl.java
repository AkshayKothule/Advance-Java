package com.endmodule.service;

import java.util.List;

import org.modelmapper.ModelMapper;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;
import org.springframework.web.bind.annotation.ExceptionHandler;

import com.endmodule.Repository.PolicyReposistory;
import com.endmodule.custome_exception.ResourceNotFouneException;
import com.endmodule.dto.PolicyDto;
import com.endmodule.entites.Policy;
import com.endmodule.entites.PolicyType;

import lombok.AllArgsConstructor;

@Service
@Transactional
@AllArgsConstructor
public class PolicyServiceImpl implements PolicyService {
	
	private PolicyReposistory policyReposistory;
	private ModelMapper modelMapper;
	
	

	@Override
	@ExceptionHandler
	public String addnewPolicy(PolicyDto policyDto) {
		
	String msg="un sucessfuly to add";
	Policy policy=modelMapper.map(policyDto, Policy.class);
	policyReposistory.save(policy);
	msg="sucessfully added new Course ........";
	
		
		return msg;
	}



	@Override
	public String deleteByPlolicyNo(Long policyNo) {
		
		String mesg="un scussfuly to delete";
		
		if(policyReposistory.existsById(policyNo)) {
			
			policyReposistory.deleteById(policyNo);
			mesg="Sucessfuly Deleted !!!!!!";
			
		}else {
			
		 throw new ResourceNotFouneException("Please Enter a correct plocy Number");
			
		}
		return mesg;
	}



	@Override
	public List<Policy> getAllPolicies() {
		return policyReposistory.findAll();
	
		
	}



	@Override
	public List<Policy> getByPolicyCategory(String policyname) {
		List<Policy> policeByType=policyReposistory.findByPolicy(PolicyType.valueOf(policyname.toUpperCase()));
		
		return policeByType;
	}

//
//
	@Override
	public List<Policy> getByPolicyName(String policeName) {
		
		return policyReposistory.findByPolicyName(policeName);
	}



	@Override
	public String updateCoverageAmount() {
		String msg="un scucessfuly to update .........";
		//find by polices
//	   policyReposistory.findAll()
//		.stream() //stream<policy>
//		.filter(p -> p.getCoverageAmount()> 700000)
//		.forEach(i-> i.setCoverageAmount(i.getCoverageAmount()*1.15));
//
		List<Policy> policyList=policyReposistory.findAll();
		
		for(Policy p : policyList) {
			if(p.getCoverageAmount() > 700000) {
				p.setCoverageAmount(p.getCoverageAmount()-p.getCoverageAmount()*0.15);
			}
		}
	   msg="Update  sucessfully !!!!!!!!";
	   
		return msg;
	}
	
	

}
