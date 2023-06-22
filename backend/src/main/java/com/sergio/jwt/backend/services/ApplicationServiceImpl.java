package com.sergio.jwt.backend.services;


import com.sergio.jwt.backend.entites.Application;
import com.sergio.jwt.backend.repositories.ApplicationRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ApplicationServiceImpl implements ApplicationService {
    private final ApplicationRepository applicationRepository;

    public ApplicationServiceImpl(ApplicationRepository applicationRepository) {
        super();
        this.applicationRepository = applicationRepository;
    }

    @Override
    public List<Application> getAllApplications() {
        return applicationRepository.findAll();
    }

    @Override
    public void saveApplication(Application application) {
        applicationRepository.save(application);
    }

    @Override
    public void deleteApplicationById(Long id) {applicationRepository.deleteById(id);}

    @Override
    public Application getApplicationById(Long id) {
        return applicationRepository.findById(id).get();
    }

    @Override
    public void editApplication(Application application) {
        applicationRepository.save(application);
    }
}
