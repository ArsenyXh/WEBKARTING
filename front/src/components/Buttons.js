import * as React from 'react';

export default function Buttons(props) {
  return (
    <div className="row">
      <div className="col-md-12 text-center" >
        <button className="btn btn-success" style={{ margin: '10px' }} onClick={props.login}>
          Войти
        </button>
        <button className="btn btn-danger" style={{ margin: '10px' }} onClick={props.logout}>
          Выйти
        </button>
      </div>
    </div>
  );
}