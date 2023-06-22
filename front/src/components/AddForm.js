// import * as React from 'react';
// export default class AddForm extends React.Component {

//     constructor(props) {
//         super(props);
//         this.state = {
//             type: "", 
//             timestart: "", 
//             timeend: "", 
//             status: 'В обработке', 
//             idcenter: "",
//             idclient: this.props.decodedToken?.iss
//         };
//     };

//     onChangeHandler = (event) => {
//         let name = event.target.name;
//         let value = event.target.value;
//         this.setState({[name] : value});
//     };

//     onSubmitRegister = (e) => {
//         this.state.onRegister(e, this.state.type, this.state.timestart, this.state.timeend, this.state.status, this.state.idcenter, this.state.idclient);
//     };
//     render() {
//         return (
//             <div className="form-outline mb-4">
//                   <label className="form-label" htmlFor="type">Тип</label>
//                     <input type="text" id="type" name="type" className="form-control" onChange={this.onChangeHandler}/>

//             <label className="form-label" htmlFor="timestart">Время начала</label>
//               <input type="text" id="timestart" name="timestart" className="form-control" onChange={this.onChangeHandler}/>

//               <label className="form-label" htmlFor="timeend">Время конца</label>
//               <input type="text" id="timeend" name="timeend" className="form-control" onChange={this.onChangeHandler}/>

//               <label className="form-label" htmlFor="idcenter">Центр</label>
//               <input type="integer" id="idcenter" name="idcenter" className="form-control" onChange={this.onChangeHandler}/>

//             </div>
//         );
//     };
// }