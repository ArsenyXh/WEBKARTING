package com.sergio.jwt.backend.services;

import com.sergio.jwt.backend.entites.Application;

import java.util.List;

public interface ApplicationService {
    List<Application> getAllApplications();
    void saveApplication(Application application);
    void deleteApplicationById(Long id);
    void editApplication(Application application);
    Application getApplicationById(Long id);
}
