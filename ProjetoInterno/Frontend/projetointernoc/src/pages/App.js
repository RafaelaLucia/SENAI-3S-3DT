import { useState, useEffect } from 'react';
import axios from 'axios';


export default function ListarMeus(){
    const [ Listar, setListar ] = useState( [] );

    function buscar(){
        axios('http://localhost:5000/api/Produtos', {
        })
        .then(r => {
            if (r.status === 200) {

                setListar( r.data );
            }
        })
        .catch( erro => console.log(erro) );
    };

    useEffect( buscar, [] );

    return(
        <div>
    <section className="section_main_consulta">
        <div className="sec_consulta">
          
   <section className="secao-minhas">
       <table>
           <tbody>
           {
               Listar.map( (pd) => {
                   return(
                    <tr key={pd.idProduto}>
                    <td>Data de Postagem: { Intl.DateTimeFormat("pt-BR", {
                    year: 'numeric', month: 'numeric', day: 'numeric',
                    }).format(new Date(pd.dataOferta)) }</td>
                   <td> Produto: {pd.nomeProduto}</td>
                   <td> Descrição: {pd.descricao}</td>
                   </tr>
                   )
                } )                                
            }
            </tbody>
               </table>
            </section>
                </div>
            </section>
            </div>
            )
        };