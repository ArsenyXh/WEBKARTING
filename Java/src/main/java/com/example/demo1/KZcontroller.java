package com.example.demo1;
import java.io.IOException;
import java.net.URL;
import java.util.*;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import java.text.DateFormat;
import java.text.SimpleDateFormat;

import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.*;
import javafx.scene.control.cell.ChoiceBoxTableCell;
import javafx.scene.control.cell.PropertyValueFactory;

import javafx.collections.FXCollections;
import javafx.collections.ObservableList;

import javafx.scene.control.cell.TextFieldTableCell;
import javafx.stage.Stage;
import javafx.util.converter.IntegerStringConverter;
import org.postgresql.Driver;
import java.sql.*;
import java.util.Date;

public class KZcontroller implements Initializable{
    private ObservableList<worker> workersData = FXCollections.observableArrayList();
    private Connection connection;
    @FXML
    private TextField telephone;
    @FXML
    private TextField password;
    @FXML
    private Button enter;

    @FXML
    private void enter(ActionEvent event) {
        Enter();
    }

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle){
    }
    private void Enter() {
        try {
            workersData.clear();
            DriverManager.registerDriver(new Driver());
            this.connection = DriverManager.getConnection("jdbc:postgresql://127.0.0.1:5432/kartingcenter", "postgres", "123");
            PreparedStatement st = connection.prepareStatement("SELECT * FROM workers WHERE role='marshal' AND telephone = ? AND password = ?");
            st.setString(1, telephone.getText());
            st.setString(2, password.getText());
            ResultSet rs = st.executeQuery();
            if (rs.next()) { // если есть совпадение по номеру телефона и паролю
                FXMLLoader loader = new FXMLLoader(getClass().getResource("planir.fxml")); // загрузка нового fxml файла
                Parent root = loader.load();
                contrl planirController = loader.getController();
                planirController.setTelephone(telephone.getText());
                Stage stage = new Stage();
                stage.setScene(new Scene(root));
                stage.show();
            } else {
                System.out.println("Неверный номер телефона или пароль"); // вывод сообщения об ошибке
            }
        } catch (SQLException | IOException e) {
            e.printStackTrace();
        }
    }
}


