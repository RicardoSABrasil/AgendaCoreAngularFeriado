import { Injectable } from "@angular/core";
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { clientes } from "../_models/clientes";

const API = 'https://localhost:44362/'
const controller = 'cliente'

@Injectable({
  providedIn: 'root'
})
export class ClienteService {
  constructor(private http : HttpClient) {}

  clientes: clientes[] | undefined;

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }  
  Listar() {
      console.log('service');
    return this.http
        .get<clientes[]>(API + controller);
  }

}
