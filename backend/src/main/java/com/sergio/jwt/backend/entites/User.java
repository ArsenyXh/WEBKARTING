package com.sergio.jwt.backend.entites;

import jakarta.persistence.*;
import jakarta.validation.constraints.Size;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.util.HashSet;
import java.util.Set;

@AllArgsConstructor
@NoArgsConstructor
@Builder
@Data
@Entity
@Table(name = "clients")
public class User {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    public Long getId() {
        return id;
    }
    public void setId(Long id) {
        this.id = id;
    }

    @Column(name = "first_name", nullable = false)
    @Size(max = 100)
    private String firstName;
    public String getFirstName() {return firstName;}
    public void setFirstName(String first_name) {this.firstName = first_name;}

    @Column(name = "last_name", nullable = false)
    @Size(max = 100)
    private String lastName;
    public String getLastName() {return lastName;}
    public void setLastName(String last_name) {this.lastName = last_name;}

    @Column(nullable = false)
    @Size(max = 100)
    private String login;

    @Column(nullable = false)
    @Size(max = 100)
    private String password;



    @Override
    public String toString(){return this.id.toString();}
}
