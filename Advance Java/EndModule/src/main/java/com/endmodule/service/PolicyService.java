package com.endmodule.service;

import java.util.List;

import com.endmodule.dto.PolicyDto;
import com.endmodule.entites.Policy;

public interface PolicyService {

	String addnewPolicy(PolicyDto policyDto);

	String deleteByPlolicyNo(Long policyNo);

	List<Policy> getAllPolicies();
//
   List<Policy> getByPolicyCategory(String policyname);
//
    List<Policy> getByPolicyName(String policeName);

	String updateCoverageAmount();
}
