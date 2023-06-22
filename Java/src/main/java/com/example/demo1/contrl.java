package com.example.demo1;

import java.net.URL;
import java.util.*;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import java.text.DateFormat;
import java.text.SimpleDateFormat;

import javafx.scene.control.*;
import javafx.scene.control.cell.ChoiceBoxTableCell;
import javafx.scene.control.cell.PropertyValueFactory;

import javafx.collections.FXCollections;
import javafx.collections.ObservableList;

import javafx.scene.control.cell.TextFieldTableCell;
import javafx.util.converter.IntegerStringConverter;
import org.postgresql.Driver;
import java.sql.*;
import java.util.Date;

public class contrl implements Initializable {
    private ObservableList<worker> workersData = FXCollections.observableArrayList();

    private ObservableList<application> applicationsData = FXCollections.observableArrayList();
    @FXML
    private TableView<application> tableApplications;
    @FXML
    private TableColumn<application, Integer> id;
    @FXML
    private TableColumn<application, String> type;
    @FXML
    private TableColumn<application,Timestamp> timestart;
    @FXML
    private TableColumn<application, Timestamp> timeend;
    @FXML
    private TableColumn<application, String> status;
    @FXML
    private TableColumn<application, Integer> idkart;
    @FXML
    private TableColumn<application, Integer> idequipment;
    @FXML
    private TableColumn<application, String> idclient;
    @FXML
    private Label telephoneLabel;
    private Connection connection;
    @FXML
    private void input(ActionEvent event) {
        initData();
    }
    public void setTelephone(String telephone) {
        telephoneLabel.setText(telephone);
    }
    @Override
    public void initialize(URL url, ResourceBundle resourceBundle){
        id.setCellValueFactory(new PropertyValueFactory<application, Integer>("id"));
        type.setCellValueFactory(new PropertyValueFactory<application, String>("type"));
        timestart.setCellValueFactory(new PropertyValueFactory<application, Timestamp>("timestart"));
        timeend.setCellValueFactory(new PropertyValueFactory<application, Timestamp>("timeend"));
        status.setCellValueFactory(new PropertyValueFactory<application, String>("status"));
        idkart.setCellValueFactory(new PropertyValueFactory<application, Integer>("idkart"));
        idequipment.setCellValueFactory(new PropertyValueFactory<application, Integer>("idequipment"));
        idclient.setCellValueFactory(new PropertyValueFactory<application, String>("idclient"));
        tableApplications.setItems(applicationsData);
        tableApplications.setEditable(true);
        status.setCellFactory(ChoiceBoxTableCell.forTableColumn(FXCollections.observableArrayList("Выполнена", "Принята")));
        status.setOnEditCommit((TableColumn.CellEditEvent<application, String> t) -> {
            application application = t.getTableView().getItems().get(t.getTablePosition().getRow());
            application.setStatus(t.getNewValue());
            updateApplication(application);
        });
    }
    private void initData() {
        try {
            applicationsData.clear();
            workersData.clear();
            DriverManager.registerDriver(new Driver());
            this.connection = DriverManager.getConnection("jdbc:postgresql://127.0.0.1:5432/kartingcenter", "postgres", "123");
            PreparedStatement st = connection.prepareStatement("SELECT  * FROM application JOIN workers w on w.id = application.idworker WHERE w.telephone = ? AND application.status='Принята'");
            st.setString(1, telephoneLabel.getText());
            ResultSet rs = st.executeQuery();

            while (rs.next()) {
                application pr = new application();
                pr.setId(rs.getInt("id"));
                pr.setType(rs.getString("type"));
                pr.setTimestart(rs.getTimestamp("timestart"));
                pr.setTimeend(rs.getTimestamp("timeend"));
                pr.setStatus(rs.getString("status"));
                pr.setIdkart(rs.getInt("idkart"));
                pr.setIdequipment(rs.getInt("idequipment"));
                pr.setIdclient(rs.getString("idclient"));
                applicationsData.add(pr);
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    private void updateApplication(application application) {
        try {
            PreparedStatement statement = connection.prepareStatement("UPDATE application SET status=? WHERE id=?");
            statement.setString(1, application.getStatus());
            statement.setInt(2, application.getId());
            statement.executeUpdate();
        } catch (SQLException e) {
            e.printStackTrace();
        }

    }
}
