import { Component } from 'react';
import axios from 'axios';
import { parseJwt, usuarioLogado } from '../services/auth';

export default class Login extends Component {
    constructor(props) {
        super(props);
        this.state = {
            email: '',
            senha: '',
            erro: '',
            isLoading: false
        };
    };

    Logar = (event) => {
       event.preventDefault();
       this.setState({erroM: '', isLoading: true});
       axios.post('http://localhost:5000/api/Login',{
           email: this.state.email,
           senha: this.state.senha
       })
       .then(answ => {
           if(answ.status === 200){
               console.log('Meu token é: ' + answ.data.tokenGerado);
               localStorage.setItem('usuario-login', answ.data.tokenGerado);
               this.setState({isLoading: false});
    
               let base64 = localStorage.getItem('usuario-login').split('.')[1];
               console.log( JSON.parse( window.atob(base64) ).role );
               this.props.history.push('/');
              
               // console.log('tá logando' + usuarioLogado())
            
           }
       }).catch(() => {
           this.setState({erroM: 'E-mail e/ou senha inválidos!!', isLoading: false})
       })
    };
    atualizarEstado = (item) => {
        this.setState({[item.target.name] : item.target.value})
    };

    render() {
        return (
        <div>
      
<section> 
        <div className="login_block">
            <div className="img-block"></div>
            <div className="block-ad">

                <h1>Login de Usuário</h1>
                <form onSubmit={this.Logar}> 

                <div className="login-section">
                    <input
                     name="email"
                     value={this.state.email}
                     id="inp-login" 
                     type="text"
                     onChange={this.atualizarEstado}
                     placeholder="Endereço de E-mail"
                     />
                    <input 
                    type="password"
                    name="senha"
                    placeholder="Senha"
                    value={this.state.senha}
                    onChange={this.atualizarEstado}
                    />

                    <a href="">Esqueceu a Senha?</a>
                </div>

                <p id="erroM-stilo">{this.state.erroM}</p>

                <div className="login-block-button">     
                {
                this.state.isLoading === true &&
                <button type="submit" disabled className="login-btn" id="btn__login">
                Loading...
                </button>
                }
                {
                    this.state.isLoading === false &&
                    <button 
                    className="login-btn" id="btn__login"
                    type="submit"
                    disabled={ this.state.email === '' || this.state.senha === '' ? 'none' : '' }>
                Login
                </button>
                }

                </div>
                </form>
                <div className="login_register">
                        <span>Não tem uma conta?</span>
                        <a href="cadastro.html">Cadastre-se</a>
                    </div>
                </div>
        </div>
</section>
        </div>
        )
    }

}