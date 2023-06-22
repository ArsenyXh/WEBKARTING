package com.example.demo1;


import java.sql.Timestamp;

public class worker {
    public int id;
    public String role;
    public String name;
    public String surname;
    public String telephone;
    public String password;
    public worker(int id, String role,String name, String surname,String telephone,String password)
    {
        this.id=id;
        this.role=role;
        this.name=name;
        this.surname=surname;
        this.telephone=telephone;
        this.password=password;
    }
    public worker() {
    }
    public int getId() {
        return id;
    }
    public void setId(int id) {
        this.id = id;
    }
    public String getTelephone() {
        return telephone;
    }
    public void setTelephone(String telephone) {
        this.telephone = telephone;
    }
    public String getPassword() {return password;}
    public void setPassword(String password) {
        this.password = password;
    }
}
