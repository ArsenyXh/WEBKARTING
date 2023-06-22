package com.example.demo1;

import java.sql.Timestamp;
import java.util.Date;

public class application {
    public int id;
    public String type;
    public Timestamp timestart;
    public Timestamp timeend;
    public int price;
    public String status;
    public int idworker;
    public int idkart;
    public int idequipment;
    public int idcenter;
    public String idclient;

    public application(int id, String type, Timestamp timestart, Timestamp timeend, int price, String status, int idworker, int idkart, int idequipment, int idcenter, String idclient)
    {
        this.id=id;
        this.type=type;
        this.timestart=timestart;
        this.timeend=timeend;
        this.price=price;
        this.status=status;
        this.idworker=idworker;
        this.idkart=idkart;
        this.idequipment=idequipment;
        this.idcenter=idcenter;
        this.idclient=idclient;
    }
    @Override
    public String toString() {
        return String.format("Номер заказа: %s | Тип заказа: %s | Время и дата начала: %s | Время и дата конца: %s | Цена: %s| Статус: %s| Номер рабочего: %s| Номер карта: %s| Номер экипировки: %s| Номер центра: %s| Почта пользователя: %s",
                this.id, this.type, this.timestart, this.timeend, this.price, this.status, this.idworker, this.idkart, this.idequipment, this.idcenter, this.idclient);}

    public application() {
    }

    public int getId() {
        return id;
    }
    public void setId(int id) {
        this.id = id;
    }

    public String getType() {
        return type;
    }
    public void setType(String type) {
        this.type = type;
    }

    public Date getTimestart() {
        return timestart;
    }
    public void setTimestart(Timestamp timestart) {
        this.timestart = timestart;
    }

    public Date getTimeend() {
        return timeend;
    }
    public void setTimeend(Timestamp timeend) {
        this.timeend = timeend;
    }

    public int getPrice() {
        return price;
    }
    public void setPrice(int price) {
        this.price = price;
    }

    public String getStatus() {
        return status;
    }
    public void setStatus(String status) {
        this.status = status;
    }

    public int getIdworker() {
        return idworker;
    }
    public void setIdworker(int idworker) {
        this.idworker = idworker;
    }

    public int getIdkart() {
        return idkart;
    }
    public void setIdkart(int idkart) {
        this.idkart = idkart;
    }

    public int getIdequipment() {
        return idequipment;
    }
    public void setIdequipment(int idequipment) {
        this.idequipment = idequipment;
    }

    public int getIdcenter() {
        return idcenter;
    }
    public void setIdcenter(int idcenter) {
        this.idcenter = idcenter;
    }

    public String getIdclient() {
        return idclient;
    }
    public void setIdclient(String idclient) {
        this.idclient = idclient;
    }



}

