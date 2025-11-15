package com.endmodule.Repository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import com.endmodule.entites.Policy;
import com.endmodule.entites.PolicyType;

public interface PolicyReposistory extends JpaRepository<Policy, Long> {
	
	List<Policy> findAll();
	List<Policy> findByPolicy(PolicyType policy);
//	List<Policy> finByPolicy(PolicyType police);
//	List<Policy> findByPolicy(PolicyType policy);
//	
	List<Policy> findByPolicyName(String policyName);

}
