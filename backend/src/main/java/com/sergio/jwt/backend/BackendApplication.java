package com.sergio.jwt.backend;

import com.sergio.jwt.backend.repositories.*;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class BackendApplication {
	@Autowired
	private UserRepository userRepository;
	@Autowired
	private ApplicationRepository applicationRepository;

	public static void main(String[] args) {
		SpringApplication.run(BackendApplication.class, args);
	}

}
