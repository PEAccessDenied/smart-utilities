import { AppComponentBase } from '@shared/app-component-base';
import { Injector, Pipe, PipeTransform } from '@angular/core';

@Pipe({
    name: 'localize'
})
export class LocalizePipe extends AppComponentBase implements PipeTransform {

    constructor(injector: Injector) {
        super(injector);
    }

    transform(key: string, ...args: any[]): string {
        return this.l(key, ...args);
    }
}
