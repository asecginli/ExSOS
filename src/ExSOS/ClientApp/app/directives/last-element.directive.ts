// ======================================
// Author: Atif SECGINLI
// Email:  info@intapptech.com
// Copyright (c) 2017 www.intapptech.com
// 
// ==> Gun4Hire: contact@intapptech.com
// ======================================

import { Directive, Input, Output, EventEmitter } from '@angular/core';


@Directive({
    selector: '[lastElement]'
})
export class LastElementDirective {
    @Input()
    set lastElement(isLastElement: boolean) {

        if (isLastElement) {
            setTimeout(() => {
                this.lastFunction.emit();
            });
        }
    }

    @Output()
    lastFunction = new EventEmitter();
}