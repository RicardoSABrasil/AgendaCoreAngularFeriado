import { Component, OnInit } from '@angular/core';
import { clientes } from 'src/app/_models/clientes';
import { ClienteService } from 'src/app/_services/clientes.service';

@Component({
  selector: 'app-lista',
  templateUrl: './lista.component.html',
  styleUrls: ['./lista.component.css']
})
export class ListaComponent implements OnInit {
  
  constructor(private service : ClienteService) {
    this.Listar();
   }

  clientes : clientes[] | undefined;

  ngOnInit(): void {
      
  }

  private Listar() {
    this.service
      .Listar()
      .subscribe(res => {
         this.clientes = res;
         console.log(this.clientes);
      });
      console.log( this.clientes);
  }


}
