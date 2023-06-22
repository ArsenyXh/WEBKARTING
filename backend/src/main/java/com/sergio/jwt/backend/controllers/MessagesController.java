package com.sergio.jwt.backend.controllers;

import com.sergio.jwt.backend.dtos.SignUpDto;
import com.sergio.jwt.backend.dtos.UserDto;
import com.sergio.jwt.backend.services.ApplicationService;
import com.sergio.jwt.backend.entites.Application;
import jakarta.validation.Valid;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.*;

import java.net.URI;
import java.util.Arrays;
import java.util.List;

@RestController
@CrossOrigin(origins = "http://localhost:3000")
@RequestMapping("/messages")
public class MessagesController {
    private final ApplicationService applicationService;

    public MessagesController(ApplicationService applicationService) {
        this.applicationService = applicationService;
    }

    @GetMapping
    public ResponseEntity<List<Application>> getApplications(){
        List<Application> applications = applicationService.getAllApplications();
        return ResponseEntity.ok(applications);
    }

    @PostMapping
    public ResponseEntity<Application> addApplication(@RequestBody Application application) {
        applicationService.saveApplication(application);
        return ResponseEntity.ok(application);
    }


}
