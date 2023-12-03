import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-componente1',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './componente1.component.html',
  styleUrl: './componente1.component.css'
})
export class Componente1Component {

  // Variável
  texto:string = 'Hello World!';

  // Objeto
  pessoa:any = {
    'nome': 'Júlio',
    'idade': 36
  };

}
