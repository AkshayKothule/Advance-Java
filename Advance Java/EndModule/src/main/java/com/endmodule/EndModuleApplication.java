package com.endmodule;

import org.modelmapper.Conditions;
import org.modelmapper.ModelMapper;
import org.modelmapper.convention.MatchingStrategies;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.Bean;

@SpringBootApplication
public class EndModuleApplication {

	public static void main(String[] args) {
		SpringApplication.run(EndModuleApplication.class, args);
	}
	@Bean
	ModelMapper modelMapper() {
		ModelMapper mapper=new ModelMapper();
		mapper.getConfiguration()
		.setPropertyCondition(Conditions.isNotNull())
		.setMatchingStrategy(MatchingStrategies.STRICT);
		return mapper;
	}


}
