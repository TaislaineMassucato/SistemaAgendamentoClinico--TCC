import { Directive } from '@angular/core';
import { ElementRef } from '@angular/core';

@Directive({
  selector: '[appBlue]'
})
export class BlueDirective {

  constructor(el: ElementRef) {
    el.nativeElement.style.color = '#00679e'
  }
}
