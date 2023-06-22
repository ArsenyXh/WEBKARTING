package com.sergio.jwt.backend.repositories;

import com.sergio.jwt.backend.entites.Application;
import org.springframework.data.repository.CrudRepository;

import java.util.List;

public interface ApplicationRepository extends CrudRepository<Application,Long> {
    List<Application> findAll();
}
