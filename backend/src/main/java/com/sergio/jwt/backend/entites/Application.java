package com.sergio.jwt.backend.entites;

import lombok.NoArgsConstructor;

import jakarta.persistence.*;
import java.sql.Timestamp;

import com.fasterxml.jackson.annotation.JsonIgnore;
import jakarta.persistence.*;

@Entity
@Table(name = "application")
@NoArgsConstructor
public class Application {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(columnDefinition = "serial", insertable = false, updatable = false)
    private Long id;
    public Long getId() {
        return id;
    }
    public void setId(Long id) {
        this.id = id;
    }

    @Column(name = "type", nullable = false)
    private String type;
    public String getType() {
        return type;
    }
    public void setType(String type) {
        this.type = type;
    }

    @Column(name = "timestart")
    private Timestamp timestart;
    public Timestamp getTimestart() {
        return timestart;
    }
    public void setTimestart(Timestamp timestart) {
        this.timestart = timestart;
    }

    @Column(name = "timeend")
    private Timestamp timeend;
    public Timestamp getTimeend() {
        return timeend;
    }
    public void setTimeend(Timestamp timeend) {
        this.timeend = timeend;
    }

    @Column(name = "price", nullable = false)
    private Integer price;
    public Integer getPrice() {
        return price;
    }
    public void setPrice(Integer price) {
        this.price = price;
    }

    @Column(name = "status", nullable = false)
    private String status;
    public String getStatus() {
        return status;
    }
    public void setStatus(String status) {
        this.status = status;
    }

    @Column(name = "idclient", nullable = false)
    private String idclient;
    public String getIdclient() {
        return idclient;
    }
    public void setIdclient(String idclient) {
        this.idclient = idclient;
    }

    @Column(name = "idworker", nullable = false)
    private Integer idworker;
    public Integer getIdworker() {
        return idworker;
    }
    public void setIdworker(Integer idworker) {
        this.idworker = idworker;
    }

    @Column(name = "idkart", nullable = false)
    private Integer idkart;
    public Integer getIdkart() {
        return idkart;
    }
    public void setIdkart(Integer idkart) {
        this.idkart = idkart;
    }

    @Column(name = "idequipment", nullable = false)
    private Integer idequipment;
    public Integer getIdequipment() {
        return idequipment;
    }
    public void setIdequipment(Integer idequipment) {
        this.idequipment = idequipment;
    }

    @Column(name = "idcenter", nullable = false)
    private Integer idcenter;
    public Integer getIdcenter() {
        return idcenter;
    }
    public void setIdcenter(Integer idcenter) {
        this.idcenter = idcenter;
    }
}