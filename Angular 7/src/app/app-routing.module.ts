import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { EmployeesComponent } from './employees/employees.component';
import { ValesComponent } from './vales/vales.component';

const routes: Routes = [
  {path: 'employee' , component: EmployeesComponent},
  {path: 'vale', component: ValesComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }