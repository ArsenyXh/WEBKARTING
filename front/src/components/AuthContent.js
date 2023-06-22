import * as React from 'react';
import moment from 'moment';
import { request, setAuthHeader } from '../helpers/axios_helper';
export default class AuthContent extends React.Component {

  constructor(props) { 
    super(props); 
    this.state = { 
      data:[],
      type: "", 
      timestart:"",  
      timeend:"",
      price: 0,  
      status:"",  
      idclient:"", 
      idcenter: 2  
    };
    this.onAdd = this.onAdd.bind(this); 
  }


  addApplication = (e) => { 
    e.preventDefault();
    this.onAdd(this.state.type, this.state.timestart, this.state.timeend, this.state.price, this.state.status, this.state.idcenter, this.state.idclient); 
  };

  onAdd(type, timestart, timeend,price, status, idcenter, idclient) { 
    const pp = type === 'Аренда' ? 500 : 1000;
    request(  
      "POST",  
      "/messages",  
      {  
        type: type,  
        timestart: moment(timestart).add(0, 'hours'),  
        timeend: moment(timestart).add(+1, 'hours'),  
        price:pp,
        status: 'В обработке',  
        idcenter: idcenter,  
        idclient: this.props.decodedToken?.iss 
      }
    ).then(  
      (response) => {  
        this.setState({ 
          type: "", 
          timestart:"",  
          timeend:"",  
          status:"",  
          idclient:"", 
          idcenter: 1 
        })
        this.componentDidMount();
      }
    ).catch(  
      (error) => {  
  
      }  
    );  
  }


 onChangeHandler = (event) => {
  let name = event.target.name;
  let value = event.target.value;
  this.setState({[name] : value});
};

 componentDidMount() {
 request(
 "GET",
 "/messages",
 {}).then(
  (response) => {
    const data = response.data.filter((item) => item.idclient === this.props.decodedToken?.iss)
    .map((item) => {
    return {
      id: item.id,
      type: item.type,
      timestart: new Date(item.timestart).toLocaleString(),
      timeend: new Date(item.timeend).toLocaleString(),
      price: item.price,
      status: item.status,
      idclient: item.idclient,
      idworker: item.idworker,
      idkart: item.idkart,
      idequipment: item.idequipment,
      idcenter: item.idcenter
    };
});
 this.setState({data: data})
 }).catch(
 (error) => {
 if (error.response.status === 401) {
 setAuthHeader(null);
 } else {
 this.setState({data: error.response.code})
 }

 }
 );
 };

 render() {
    return (
      <div>
        <h2>Оформить заявку</h2>
      <form onSubmit={this.addApplication}> 
      <div className="form-outline mb-4">  
      <label className="form-label" htmlFor="type">Тип</label>  
      <select id="type" name="type" className="form-control" onChange={this.onChangeHandler}>
      <option value='Аренда'>Аренда</option>
      <option value='Обучение'>Обучение</option>
      </select>
      </div>
          <div className="form-outline mb-4"> 
            <label className="form-label" htmlFor="timestart">Время начала (Продолжительность аренды или обучения: 1 час)</label>  
            <input type="datetime-local" id="timestart" name="timestart" className="form-control" onChange={this.onChangeHandler}/>  
          </div> 
          
          <div className="form-outline mb-4">  
          <label className="form-label" htmlFor="idcenter">Центр</label>  
          <select id="idcenter" name="idcenter" className="form-control" onChange={this.onChangeHandler}>
          <option value="1">Картинг центр номер 1, Адресс: Октябрьский проспект 7</option>
          <option value="2">Картинг центр номер 2, Адресс: Преображенская 45</option>
          </select>
        </div> 
          <button type="submit" className="btn btn-success btn-block mb-3">Добавить заявку</button> 
        </form> 
        <h2>Ваши заявки</h2>
        <table className="table table-striped table-bordered">
        <thead className="table-dark">
          <tr>
            <th>Номер</th>
            <th>Тип</th>
            <th>Начало</th>
            <th>Конец</th>
            <th>Цена</th>
            <th>Статус</th>
            <th>Клиент</th>
            <th>Центр</th>
          </tr>
        </thead>
        <tbody>
          {this.state.data && this.state.data.map((item) => (
              <tr>
              <td>{item.id}</td>
              <td>{item.type}</td>
              <td>{item.timestart}</td>
              <td>{item.timeend}</td>
              <td>{item.price}</td>
              <td>{item.status}</td>
              <td>{item.idclient}</td>
              <td>{item.idcenter}</td>
              </tr>
          ))}
        </tbody>
      </table>  
      </div>   
    );
  };
}